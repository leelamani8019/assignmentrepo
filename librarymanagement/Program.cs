public class libbook
{
    public static void Main()
    {
        //librarymanagement.books b=new librarymanagement.books();
        //b.createfile();
        librarymanagement.users u=new librarymanagement.users();
        u.StoreBorrowerDetails("manisha",9,"java");
        u.StoreBorrowerDetails("nimisha", 34, "xml");
        u.StoreBorrowerDetails("anuradha", 99, "3boats");
        u.UpdateBooksDetailFile("mathmatics");
        u.UpdateBooksDetailFile("harrypotter");
        librarymanagement.issue i=new librarymanagement.issue();
        i.bookissue();


    }
}