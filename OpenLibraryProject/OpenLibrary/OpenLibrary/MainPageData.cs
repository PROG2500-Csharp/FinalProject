using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary
{
    class MainPageData :INotifyPropertyChanged
    {
        private List<BookModel> _allBooks = new List<BookModel>();

        public ObservableCollection<BookModel> Books { get; set; }



        private String _searchTerm = "Placeholder for what was searched";
        private String _displayTitle = "No Book Seleceted";
        private int _firstPublishedYear = 1984;
        private String _bookAuthorName = "John Doe";
        private String _bookCoverImage = "blank.jpg";

        public String searchTerm
        {
            get { return _searchTerm; } 
            set
            {
                if (value == _searchTerm)
                    return;

                _searchTerm = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(searchTerm)));   
            }
        }
        public String displayTitle
        {
            get { return _displayTitle; }
            set
            {
                if (value == _displayTitle)
                    return;

                _displayTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(displayTitle)));
            }
        }

        public int firstPublishedYear
        {
            get { return _firstPublishedYear; }
            set
            {
                if (value == _firstPublishedYear)
                    return;

                _firstPublishedYear = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(firstPublishedYear)));
            }
        }
        public String bookAuthorName
        {
            get { return _bookAuthorName; }
            set
            {
                if (value == _bookAuthorName)
                    return;

                _bookAuthorName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(bookAuthorName)));
            }
        }
        public String bookCoverImage
        {
            get { return _bookCoverImage; }
            set
            {
                if (value == _bookCoverImage)
                    return;

                _bookCoverImage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(bookCoverImage)));
            }
        }



        public MainPageData()
        {
            Books = new ObservableCollection<BookModel>();

            //_allBooks.Add(new OpenLibrary.BookModel("Book a", 1984, "john smith", "cover1.jpg"));
            //_allBooks.Add(new OpenLibrary.BookModel("Book b", 2010, "alex jones", "cover2.jpg"));
            //_allBooks.Add(new OpenLibrary.BookModel("Book c", 2000, "jim johnson", "cover3.jpg"));
            //_allBooks.Add(new OpenLibrary.BookModel("Book d", 2002, "jay smith", "cover5.jpg"));
            //_allBooks.Add(new OpenLibrary.BookModel("Book e", 1991, "michael johnson", "cover5.jpg"));

            //PerformFiltering();

            LoadData();
        }

        private async void LoadData()
        {
            _allBooks = await BookRepository.GetAllBooksAsync();
            PerformFiltering();
        }

        private BookModel _selectedBook;

        public event PropertyChangedEventHandler PropertyChanged;

        public BookModel SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                if (value == null)
                {
                    displayTitle = "No Book Selected";
                    firstPublishedYear = 1984;
                    bookAuthorName = "nobody";
                    bookCoverImage = "nothing.jpg";
                }
                    
                else
                {
                    displayTitle = value.title_suggest;
                    firstPublishedYear = value.first_publish_year;
                    bookAuthorName = value.author_name;
                    bookCoverImage = value.cover_i;
                }
            }
        }

        private string _filter;
        public string Filter
        {
            get { return _filter; }
            set
            {
                if (value == _filter)
                    return;

                _filter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Filter)));
                PerformFiltering();
            }

        }

        private void PerformFiltering()
        {
            if (_filter == null)
                _filter = "";

            var lowerCaseFilter = Filter.ToLowerInvariant().Trim();

            var result = _allBooks.Where(d => d.title_suggest.ToLowerInvariant().Contains(lowerCaseFilter)).ToList();

            var toRemove = Books.Except(result).ToList();

            foreach (var x in toRemove)
                Books.Remove(x);

            var resultCount = result.Count;
            
            for (int i=0; i<resultCount;i++)
            {
                var resultItem = result[i];
                if (i + 1 > Books.Count || !Books[i].Equals(resultItem))
                    Books.Insert(i, resultItem);
            }
        }
    }
}
