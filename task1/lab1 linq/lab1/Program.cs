using System;
using System.Linq;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           // //1111111111111111111111111111111111111
           // var query1 =
           //     from B in SampleData.Books
           //     select new { title = B.Title, isbn = B.Isbn };
           // foreach (var item in query1)
           // {
           //     Console.WriteLine(item.title);
           //     Console.WriteLine(item.isbn);
           // }
           // Console.WriteLine();

           // //2222222222222222222222222222222222

           // var query2 = SampleData.Books.Where(B => B.Price > 25).Take(3);

           // foreach (var item in query2)
           // {
           //     Console.WriteLine(item);

           // }
           // Console.WriteLine();

           // //33333333333333333333333333333333333333333

           // var query3 =
           //     from B in SampleData.Books
           //     select new
           //     {
           //         title = B.Title,
           //         namepup =
           //         from p in SampleData.Publishers
           //         where p.Name == B.Publisher.Name
           //         select new { p_name = p.Name }
           //     };

           // foreach (var item in query3)
           // {
           //     Console.WriteLine(item.title);

           //     foreach (var item2 in item.namepup)
           //     {
           //         Console.WriteLine(item2.p_name);
           //     }
           // }

           // var query4 = SampleData.Books.Select(B => new
           // {
           //     title = B.Title,
           //     namepup =
           //       from p in SampleData.Publishers
           //       where p.Name == B.Publisher.Name
           //       select new { p_name = p.Name }
           // });

           // Console.WriteLine();

           // foreach (var item in query4)
           // {
           //     Console.WriteLine(item.title);

           //     foreach (var item2 in item.namepup)
           //     {
           //         Console.WriteLine(item2.p_name);
           //     }
           // }

           // Console.WriteLine();

           // //44444444444444444444444444444444444444444444444

           // var query5 = (from B in SampleData.Books
           //               where B.Price > 20
           //               select B).Count();

           // Console.WriteLine(query5);
           // Console.WriteLine();

           // //55555555555555555555555555555555555555555

           // var query6 =
           //     from B in SampleData.Books
           //     orderby B.Subject.Name ascending, B.Price descending
           //     select new
           //     {
           //         title = B.Title,
           //         price = B.Price,
           //         supjectname = B.Subject.Name
           //     };

           // foreach (var item in query6)
           // {
           //     Console.WriteLine(item.title);
           //     Console.WriteLine(item.price);
           //     Console.WriteLine(item.supjectname);


           // }
           // Console.WriteLine();

           // //6666666666666666666666666666666666666666666666666666

           // var query7 =
           //     from s in SampleData.Subjects
           //     select new
           //     {
           //         subject = s,
           //         books =
           //        from B in SampleData.Books
           //        where s.Name == B.Subject.Name
           //        select B

           //     };

           // foreach (var item in query7)
           // {
           //     Console.WriteLine(item.subject);

           //     foreach (var item2 in item.books)
           //     {
           //         Console.WriteLine(item2);
           //     }
           // }

           // Console.WriteLine();

           // var query8 = SampleData.Subjects.Select(s =>
           //new
           //{
           //    subject = s,
           //    books =
           //       from B in SampleData.Books
           //       where s.Name == B.Subject.Name
           //       select B
           //});

           // foreach (var item in query8)
           // {
           //     Console.WriteLine(item.subject);

           //     foreach (var item2 in item.books)
           //     {
           //         Console.WriteLine(item2);
           //     }
           // }
           // Console.WriteLine();
           // //7777777777777777777777777777777777777777777777777777



           // var query9 = SampleData.GetBooks().OfType<Book>();

           // foreach (var item in query9)
           // {

           //     Console.WriteLine(item.Title);
           //     Console.WriteLine(item.Price);

           // }
           // Console.WriteLine();

            //8888888888888888888888888888888888888888888888888
            var query10 = SampleData.Books.GroupBy(b => new { p = b.Publisher, s = b.Subject }).ToList();


            foreach (var item in query10)
            {
                Console.WriteLine(item.Key.p.Name);
                Console.WriteLine(item.Key.s.Name);

            }



            Console.WriteLine();

            











        }
    }
}
