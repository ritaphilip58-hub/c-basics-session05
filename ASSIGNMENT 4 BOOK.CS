using assignment_4;

    book b = new book();
#region Q1
//Console.WriteLine(b.password);
//error because password is private
#endregion



#region Q2
Console.WriteLine(b.CopiesInStock);
// it complies because internal allows access to the field from any class to same assembly
#endregion



#region Q3
b.Title = "The litle prince";
Console.WriteLine(b.Title);
#endregion



#region Q4
b.Genre = Genre.Science;
Console.WriteLine(b.Genre);
#endregion




#region Q5
Console.WriteLine((int) Genre.fiction);
Console.WriteLine((int)Genre.Nonfiction);
Console.WriteLine( (int)Genre.Science);
#endregion



#region Q6
int genreNumber = 1;
Genre genre1 = (Genre)genreNumber;
Console.WriteLine(genre1);
#endregion


#region Q7
Genre genre2 = Genre.fiction;
Console.WriteLine(genre2.ToString());
#endregion



#region Q8
string genreText = "Science";
Genre genre3 = (Genre)Enum.Parse (typeof(Genre),genreText); 
    Console.WriteLine(genre3);
#endregion


#region Q9
string genreText4= "Mystery";
bool isvalid = Enum.TryParse(genreText4, out Genre genre4);
if (isvalid)
{
    Console.WriteLine(genre4);
}
else
{
    Console.WriteLine("unknown genre");

}
#endregion