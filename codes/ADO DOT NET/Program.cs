using ADO_DOT_NET;

string _connectionString = @"Server=LAPTOP-88GU3220\SQLEXPRESS08;Database=CsharpB11;Trusted_Connection=True";

DataHelper dataHelper = new DataHelper(_connectionString);

//string name = Console.ReadLine();
//decimal cgpa = decimal.Parse(Console.ReadLine());
//DateTime dob = DateTime.Parse(Console.ReadLine());
//Guid sid = Guid.Parse(Console.ReadLine());
//bool isActive = bool.Parse(Console.ReadLine());

//Dictionary<string, object> parameters = new Dictionary<string, object>();

//parameters.Add("Name", name);
//parameters.Add("Cgpa", cgpa);
//parameters.Add("DateOfBirth", dob);
//parameters.Add("StudentId", sid);
//parameters.Add("IsActive", isActive);

//string sqlInsert = "insert into student([name], cgpa, dateofbirth, studentid, isactive) values(@Name, @Cgpa, @DateOfBirth, @StudentId, @IsActive)";
string sqlUpdate = "update student set name = 'Rafiq', Cgpa = 4.0 where id = 2";
//string sqlDelete = "delete from student where id = 3";
//string sqlRead = "select * from student";

//dataHelper.WriteOperation(sqlInsert, parameters);

dataHelper.UpdateOperation(sqlUpdate);

//dataHelper.DeleteOperation(sqlDelete);

//var data = dataHelper.ReadOperation(sqlRead);

//foreach(Dictionary<string, object> item in data)
//{
//    foreach(var key in item.Keys)
//    {
//        Console.Write($"{key}:{item[key]}, " );
//    }
//    Console.WriteLine();
//}


Console.WriteLine("Complete");

