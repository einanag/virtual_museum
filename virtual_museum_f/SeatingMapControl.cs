using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace virtual_museum_f
{
    [DesignerCategory("code")]
    public partial class SeatingMapControl : UserControl
    {
        private Dictionary<string, SeatInfo> seats;
        private List<Zone> zones;
        private const int SEAT_SIZE = 26;
        private const int ROWS = 17;
        private const int SEATS_PER_ROW = 23;
        private const int START_X = 20;
        private const int START_Y = 80;

        public event EventHandler<SeatSelectedEventArgs> SeatSelected;
        public event EventHandler<SeatSelectedEventArgs> SeatUnselected;

        public SeatingMapControl()
        {
            InitializeComponent();
            InitializeZones();
            InitializeSeats();
            this.DoubleBuffered = true;
            this.MouseClick += SeatingMapControl_MouseClick;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private class SeatInfo
        {
            public int Status { get; set; }
            public Zone Zone { get; set; }
        }

        private void InitializeZones()
        {
            zones = new List<Zone>
            {
                new Zone { Name = "VIP", Price = 150, Color = Color.Gold },
                new Zone { Name = "ΔΙΑΚΕΚΡΙΜΕΝΗ", Price = 120, Color = Color.Orange },
                new Zone { Name = "Α ΖΩΝΗ", Price = 90, Color = Color.Purple },
                new Zone { Name = "Β ΖΩΝΗ", Price = 70, Color = Color.Blue },
                new Zone { Name = "Γ ΖΩΝΗ", Price = 50, Color = Color.Green },
                new Zone { Name = "Δ ΖΩΝΗ", Price = 40, Color = Color.Pink },
                new Zone { Name = "Ε ΖΩΝΗ", Price = 30, Color = Color.Magenta }
            };
        }

        private void InitializeSeats()
        {
            seats = new Dictionary<string, SeatInfo>();
            for (int row = 0; row < ROWS; row++)
            {
                for (int seat = 0; seat < SEATS_PER_ROW; seat++)
                {
                    string seatId = $"{(char)('A' + row)}{seat + 1:00}";
                    Zone zone = DetermineZone(row);
                    seats[seatId] = new SeatInfo { Status = 0, Zone = zone };
                }
            }
        }

        /// <summary>
        /// VIP
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        //ΔΙΑΚΕΚΡΙΜΕΝΗ
        // Α ΖΩΝΗ
        // Β ΖΩΝΗ
        // Γ ΖΩΝΗ
        // Δ ΖΩΝΗ
        // Ε ΖΩΝΗ
        private Zone DetermineZone(int row)
        {
            if (row < 2) return zones[0];
            if (row < 4) return zones[1];
            if (row < 7) return zones[2];
            if (row < 10) return zones[3];
            if (row < 13) return zones[4];
            if (row < 15) return zones[5];
            return zones[6];
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int stageWidth = SEATS_PER_ROW * (SEAT_SIZE + 2);
            int stageHeight = 30;
            int stageY = START_Y - stageHeight - 5;

            //stage
            g.FillRectangle(Brushes.Red, START_X, stageY, stageWidth, stageHeight);
            using (Font stageFont = new Font("Arial", 12, FontStyle.Bold))
            {
                SizeF textSize = g.MeasureString("STAGE", stageFont);
                float textX = START_X + (stageWidth - textSize.Width) / 2;
                float textY = stageY + (stageHeight - textSize.Height) / 2;
                g.DrawString("STAGE", stageFont, Brushes.White, textX, textY);
            }

            int soundBoothWidth = 120;
            int soundBoothHeight = 25;
            int soundBoothX = START_X + (stageWidth - soundBoothWidth) / 2;
            int soundBoothY = stageY - soundBoothHeight - 5;
            g.FillRectangle(Brushes.Red, soundBoothX, soundBoothY, soundBoothWidth, soundBoothHeight);
            using (Font soundBoothFont = new Font("Arial", 8, FontStyle.Bold))
            {
                SizeF textSize = g.MeasureString("SOUND BOOTH", soundBoothFont);
                float textX = soundBoothX + (soundBoothWidth - textSize.Width) / 2;
                float textY = soundBoothY + (soundBoothHeight - textSize.Height) / 2;
                g.DrawString("SOUND BOOTH", soundBoothFont, Brushes.White, textX, textY);
            }

            DrawExitSign(g, START_X, 10);
            DrawExitSign(g, START_X + stageWidth - 50, 10);
            DrawSeats(g);
            DrawZoneLegend(g, START_X + stageWidth + 10, START_Y);
        }

        private void DrawSeats(Graphics g)
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int seat = 0; seat < SEATS_PER_ROW; seat++)
                {
                    string seatId = $"{(char)('A' + row)}{seat + 1:00}";
                    SeatInfo info = seats[seatId];
                    int x = START_X + seat * (SEAT_SIZE + 2);
                    int y = START_Y + row * (SEAT_SIZE + 2);

                    Color seatColor = info.Status == 1 ? Color.Yellow : (info.Status == 2 ? Color.Gray : info.Zone.Color);
                    g.FillRectangle(new SolidBrush(seatColor), x, y, SEAT_SIZE, SEAT_SIZE);
                    g.DrawRectangle(Pens.Black, x, y, SEAT_SIZE, SEAT_SIZE);

                    using (Font seatFont = new Font("Arial", 6f, FontStyle.Bold))
                    {
                        SizeF textSize = g.MeasureString(seatId, seatFont);
                        float textX = x + (SEAT_SIZE - textSize.Width) / 2;
                        float textY = y + (SEAT_SIZE - textSize.Height) / 2;
                        g.DrawString(seatId, seatFont, Brushes.Black, textX, textY);
                    }
                }
            }
        }

        private void DrawZoneLegend(Graphics g, int x, int y)
        {
            int rectSize = 15;
            int spacing = 2;
            using (Font legendFont = new Font("Arial", 7, FontStyle.Bold))
            {
                foreach (var zone in zones)
                {
                    g.FillRectangle(new SolidBrush(zone.Color), x, y, rectSize, rectSize);
                    g.DrawString($"{zone.Name}-{zone.Price}€", legendFont, Brushes.Black, x + rectSize + spacing, y);
                    y += rectSize + spacing + 2;
                }
            }
        }

        private void DrawExitSign(Graphics g, int x, int y)
        {
            g.FillRectangle(Brushes.Red, x, y, 50, 20);
            g.DrawString("EXIT", new Font("Arial", 8, FontStyle.Bold), Brushes.White, x + 5, y + 2);
        }

        private void SeatingMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            int row = (e.Y - START_Y) / (SEAT_SIZE + 2);
            int seat = (e.X - START_X) / (SEAT_SIZE + 2);

            if (row >= 0 && row < ROWS && seat >= 0 && seat < SEATS_PER_ROW)
            {
                string seatId = $"{(char)('A' + row)}{seat + 1:00}";
                if (seats[seatId].Status == 0)
                {
                    seats[seatId].Status = 1;
                    SeatSelected?.Invoke(this, new SeatSelectedEventArgs(seatId, seats[seatId].Zone));
                }
                else if (seats[seatId].Status == 1)
                {
                    seats[seatId].Status = 0;
                    SeatUnselected?.Invoke(this, new SeatSelectedEventArgs(seatId, seats[seatId].Zone));
                }
                else if (seats[seatId].Status == 2)
                {
                    MessageBox.Show("Αυτή η θέση δεν είναι διαθέσιμη.", "Μη διαθέσιμη θέση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Invalidate();
            }
        }

        public void UpdatePrices(Label priceLabel)
        {
            decimal totalPrice = seats.Where(s => s.Value.Status == 1).Sum(s => s.Value.Zone.Price);
            priceLabel.Text = $"Συνολική τιμή: {totalPrice} €";
        }

        public void FinalizeBooking()
        {
            foreach (var seat in seats.Where(s => s.Value.Status == 1))
            {
                seat.Value.Status = 2;
            }
            this.Invalidate();
        }

        public void ClearSelectedSeats()
        {
            foreach (var seat in seats.Where(s => s.Value.Status == 1))
            {
                seat.Value.Status = 0;
            }
            this.Invalidate();
        }

        public decimal GetTotalPrice()
        {
            return seats.Where(s => s.Value.Status == 1).Sum(s => s.Value.Zone.Price);
        }
    }

    public class Zone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Color Color { get; set; }
    }

    public class SeatSelectedEventArgs : EventArgs
    {
        public string SeatId { get; }
        public Zone SelectedZone { get; }

        public SeatSelectedEventArgs(string seatId, Zone zone)
        {
            SeatId = seatId;
            SelectedZone = zone;
        }
    }
}