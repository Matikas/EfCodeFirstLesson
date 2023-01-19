using EfCodeFirstLesson;
using Microsoft.EntityFrameworkCore;

// INSERT:
//using var dbContext = new BookContext();
//var newPage = new Page(1, "kazkoks turinys");
//dbContext.Pages.Add(newPage);
//dbContext.SaveChanges();

// SELECT:
//using var dbContext = new BookContext();
//var pageFromDb = dbContext.Pages.FirstOrDefault(p => p.Id == Guid.Parse("5EBDC1A3-B502-4930-8797-8CBCE53F95A6"));
//Console.WriteLine($"puslapio nr {pageFromDb.Number} ir turinys {pageFromDb.Content}");

// UPDATE:
//using var dbContext = new BookContext();
//var pageFromDb = dbContext.Pages.FirstOrDefault(p => p.Id == Guid.Parse("5EBDC1A3-B502-4930-8797-8CBCE53F95A6"));
//pageFromDb.Content = "pakeistas puslapio turinys";
//dbContext.SaveChanges();

// DELETE su selectu:
//using var dbContext = new BookContext();
//var pageFromDb = dbContext.Pages.FirstOrDefault(p => p.Id == Guid.Parse("5EBDC1A3-B502-4930-8797-8CBCE53F95A6"));
//dbContext.Pages.Remove(pageFromDb);
//dbContext.SaveChanges();

// DELETE be selecto
//using var dbContext = new BookContext();
//var pageToDelete = new Page { Id = Guid.Parse("2F27824A-A22A-47B5-AB17-DC3C297B830D") };
//dbContext.Pages.Remove(pageToDelete);
//dbContext.SaveChanges();


//using var dbContext = new BookContext();
//var book = new Book("Harry Potter");
//for (int i = 0; i < 565; i++)
//{
//    book.Pages.Add(new Page(i, $"content - {i}"));
//}
//dbContext.Books.Add(book);
//dbContext.SaveChanges();

//using var dbContext = new BookContext();
//var harryPotterBook = dbContext.Books.Include(b => b.Pages).FirstOrDefault(b => b.Name == "Harry Potter");
//Console.WriteLine($"Book Id: {harryPotterBook.Id}");
//Console.WriteLine("Book pages");
//foreach (var page in harryPotterBook.Pages)
//{
//    Console.WriteLine($"Page number: {page.Number}, content: {page.Content}");
//}

using var dbContext = new BookContext();
var harryPotterBook = dbContext.Books.Include(b => b.Pages).FirstOrDefault(b => b.Name == "Harry Potter");
dbContext.Books.Remove(harryPotterBook);
dbContext.SaveChanges();