

using Microsoft.EntityFrameworkCore;

namespace EF_core_02_Sales_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // بشمهندس انا طبعا عدلت شوية في قصة لازمة من الطرفين او  مش لازمة علشان بس اعرف ادخل البيانات[mandatory or not] 

            #region CRUD
            using (var context = new dbcontext())
            {

                #region try to add data to all database  ... Eng yassin I Commented IsRequired() to add data 

                //var manager = new Employee
                //{
                //    Name = "Ahmed Ali",

                //};
                //context.Set<Employee>().Add(manager);
                //context.SaveChanges();


                //    var office = new Sales_Office
                //    {
                //        Location = "Cairo",
                //        ManagerId = manager.Id
                //    };
                //    context.Set<Sales_Office>().Add(office);
                //    context.SaveChanges();


                //    var owner = new Owner
                //    {
                //        Name = "Kero Ashraf",

                //    };
                //    context.Set<Owner>().Add(owner);
                //    context.SaveChanges();


                //    var property = new Property
                //    {
                //        Location = "Garden View",
                //        Address = "123 Main St",
                //        City = "Cairo",
                //        State = "Giza",
                //        Code = 11223,
                //        SalesOfficeId = office.Number
                //    };
                //    context.Set<Property>().Add(property);
                //    context.SaveChanges();


                //    var ownedProperty = new Owned_Property
                //    {
                //        Owner_id = owner.Id,
                //        Property_id = property.Id,
                //        Precent = 50
                //    };
                //    context.Set<Owned_Property>().Add(ownedProperty);
                //    context.SaveChanges();

                //    Console.WriteLine("Done");
                //
                #endregion
                #region select delete update 
                //var allEmployees = context.Set<Employee>().ToList();
                //Console.WriteLine("\n All Employees:");
                //foreach (var emp in allEmployees)
                //{
                //    Console.WriteLine($"{emp.Id} - {emp.Name} ");
                //}

                //var firstEmployee = context.Set<Employee>().FirstOrDefault();
                //if (firstEmployee != null)
                //{
                //    firstEmployee.Name = "Kero Ashraf"; // change name
                //    context.SaveChanges();
                //    Console.WriteLine($"\nUpdated Employee Id {firstEmployee.Id} - New Name = {firstEmployee.Name}");
                //}



                //var lastEmployee = context.Set<Employee>().FirstOrDefault();
                //if (lastEmployee != null)
                //{
                //    context.Set<Employee>().Remove(lastEmployee);
                //    context.SaveChanges();
                //    Console.WriteLine($"\nDeleted Employee: {lastEmployee.Name}");
                //}


                #endregion
            }
            #endregion
            #region Eager Loading
            //using (var context = new dbcontext())
            //{
            //    var employees = context.Set<Employee>()
            //           .Include(e => e.SalesOffice) 
            //           .ToList();

            //    foreach (var emp in employees)
            //    {
            //        Console.WriteLine($"Employee: {emp.Name}, Office: {emp.SalesOffice?.Number}");
            //    }

            //}


            #endregion
            #region Lazy Loading
            //using (var context = new dbcontext())
            //  {



            //    var employees = context.Set<Employee>().ToList(); // هنا مفيش Include

            //    foreach (var emp in employees)
            //    {
            //        Console.WriteLine($"Employee: {emp.Name}, Office: {emp.SalesOffice?.Number}");
            //    }

            //}
            #endregion
        }
    }
}
