using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace virtual_museum_f
{
    public class MuseumDatabase
    {
        private static MuseumDatabase _instance;
        private static readonly object _lock = new object();
        private string connectionString;

        public static MuseumDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "museum.db");
                            _instance = new MuseumDatabase(dbPath);
                        }
                    }
                }
                return _instance;
            }
        }
        private MuseumDatabase(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Exhibitions (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Visitors INTEGER,
                            Views INTEGER
                        );
                        
                        CREATE TABLE IF NOT EXISTS Orders (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            OrderDate DATETIME NOT NULL,
                            TotalAmount REAL NOT NULL,
                            OrderDetails TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Bookings (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            EventName TEXT NOT NULL,
                            BookingDate DATETIME NOT NULL,
                            TotalAmount REAL NOT NULL,
                            Comments TEXT,
                            Seats TEXT
                        );

                        CREATE TABLE IF NOT EXISTS DJBookings (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            BookingDate DATETIME NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS UserSelections (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            EventType TEXT NOT NULL,
                            EventName TEXT NOT NULL,
                            OrderDate DATETIME NOT NULL,
                            TotalAmount REAL NOT NULL,
                            Comments TEXT
                        );

                        CREATE TABLE IF NOT EXISTS CafeteriaOrders (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            OrderDate DATETIME NOT NULL,
                            TotalAmount REAL NOT NULL,
                            OrderDetails TEXT
                        );
                    ";
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to add a cafeteria order
        public void AddCafeteriaOrder(CafeteriaOrder order)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO CafeteriaOrders (OrderDate, TotalAmount, OrderDetails) VALUES (@OrderDate, @TotalAmount, @OrderDetails)";
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                    command.Parameters.AddWithValue("@OrderDetails", order.OrderDetails);
                    command.ExecuteNonQuery();
                }
            }
        }
        // Method to retrieve cafeteria orders
        public List<CafeteriaOrder> GetCafeteriaOrders()
        {
            var orders = new List<CafeteriaOrder>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM CafeteriaOrders", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new CafeteriaOrder
                        {
                            Id = reader.GetInt32(0),
                            OrderDate = reader.GetDateTime(1),
                            TotalAmount = reader.GetDecimal(2),
                            OrderDetails = reader.GetString(3)
                        });
                    }
                }
            }
            return orders;
        }

        // Method to add an exhibition
        public void AddExhibition(Exhibition exhibition)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Exhibitions (Name, Visitors, Views) VALUES (@Name, @Visitors, @Views)";
                    command.Parameters.AddWithValue("@Name", exhibition.Name);
                    command.Parameters.AddWithValue("@Visitors", exhibition.Visitors);
                    command.Parameters.AddWithValue("@Views", exhibition.Views);
                    command.ExecuteNonQuery();
                }
            }
        }

        //retrieve exhibitions
        public List<Exhibition> GetExhibitions()
        {
            var exhibitions = new List<Exhibition>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Exhibitions", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exhibitions.Add(new Exhibition
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Visitors = reader.GetInt32(2),
                            Views = reader.GetInt32(3)
                        });
                    }
                }
            }
            return exhibitions;
        }

        //update exhibition views
        public void UpdateExhibitionViews(string exhibitionName, int views)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE Exhibitions SET Views = @Views WHERE Name = @Name";
                    command.Parameters.AddWithValue("@Views", views);
                    command.Parameters.AddWithValue("@Name", exhibitionName);
                    command.ExecuteNonQuery();
                }
            }
        }

        //add an event        
        public void AddEvent(Event ev)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Events (Description, FromDate, ToDate) VALUES (@Description, @FromDate, @ToDate)";
                    command.Parameters.AddWithValue("@Description", ev.Description); // Assuming Name is actually Description
                    command.Parameters.AddWithValue("@FromDate", ev.FromDate); // Assuming FromDate is of type DateTime
                    command.ExecuteNonQuery();
                }
            }
        }


        //retrieve events
        public List<Event> GetEvents()
        {
            var events = new List<Event>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Events", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        events.Add(new Event
                        {
                            EventID = reader.GetInt32(0),
                            FromDate = reader.GetString(1),
                            Description = reader.GetString(2)
                        });
                    }
                }
            }
            return events;
        }


        //add an order
        public void AddOrder(Order order)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Orders (OrderDate, TotalAmount, OrderDetails) VALUES (@OrderDate, @TotalAmount, @OrderDetails)";
                    command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                    command.Parameters.AddWithValue("@OrderDetails", order.OrderDetails);
                    command.ExecuteNonQuery();
                }
            }
        }

        //retrieve orders
        public List<Order> GetOrders()
        {
            var orders = new List<Order>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Orders", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            Id = reader.GetInt32(0),
                            OrderDate = reader.GetDateTime(1),
                            TotalAmount = reader.GetDecimal(2),
                            OrderDetails = reader.GetString(3)
                        });
                    }
                }
            }
            return orders;
        }

        //add a booking
        public void AddBooking(Booking booking, decimal totalAmount, string comments, string seats)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO Bookings (EventName, BookingDate, TotalAmount, Comments, Seats) VALUES (@EventName, @BookingDate, @TotalAmount, @Comments, @Seats)";
                    command.Parameters.AddWithValue("@EventName", booking.EventName);
                    command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                    command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    command.Parameters.AddWithValue("@Comments", comments);
                    command.Parameters.AddWithValue("@Seats", seats);
                    command.ExecuteNonQuery();
                }
            }
        }

        //retrieve bookings
        public List<Booking> GetBookings()
        {
            var bookings = new List<Booking>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Bookings", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            Id = reader.GetInt32(0),
                            EventName = reader.GetString(1),
                            BookingDate = reader.GetDateTime(2),
                            TotalAmount = reader.GetDecimal(3),
                            Comments = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Seats = reader.IsDBNull(5) ? null : reader.GetString(5)
                        });
                    }
                }
            }
            return bookings;
        }

        //add a DJ booking
        public int AddDJBooking(DJBooking djBooking)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = "INSERT INTO DJBookings (BookingDate) VALUES (@BookingDate); SELECT last_insert_rowid();";
                    command.Parameters.AddWithValue("@BookingDate", djBooking.BookingDate);
                    return Convert.ToInt32(command.ExecuteScalar()); // Return the ID of the newly inserted booking
                }
            }
        }

        //retrieve DJ bookings
        public List<DJBooking> GetDJBookings()
        {
            var djBookings = new List<DJBooking>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM DJBookings", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        djBookings.Add(new DJBooking
                        {
                            Id = reader.GetInt32(0),
                            BookingDate = reader.GetDateTime(1)
                        });
                    }
                }
            }
            return djBookings;
        }
        //get occupied dates for DJ bookings
        public List<DateTime> GetOccupiedDates()
        {
            var occupiedDates = new List<DateTime>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT BookingDate FROM DJBookings", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        occupiedDates.Add(reader.GetDateTime(0));
                    }
                }
            }
            return occupiedDates;
        }
    }
    public class CafeteriaOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderDetails { get; set; }
    }
    public class Exhibition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Visitors { get; set; }
        public int Views { get; set; }
    }

    public class Event
    {
        public int EventID { get; set; }
        public string FromDate { get; set; }
        public string Description { get; set; }
    }



    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderDetails { get; set; }
    }

    public class Booking
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Comments { get; set; }
        public string Seats { get; set; }
    }

    public class DJBooking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
    }
}