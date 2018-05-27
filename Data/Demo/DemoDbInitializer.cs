namespace IntercityBusService.Data
{
    public static class DemoDbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Users.AddRange(DemoData.Users);
            context.SaveChanges();

            context.Buses.AddRange(DemoData.Buses);
            context.SaveChanges();

            context.Rides.AddRange(DemoData.Rides);
            context.SaveChanges();

            context.Tickets.AddRange(DemoData.Tickets);
            context.SaveChanges();
        }
    }
}