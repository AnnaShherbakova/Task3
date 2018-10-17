using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Book:IEdition
    {
        public int Year { get; set; }//год печати
        public int AmountAuthor { get; set; }
        public string Format { get; set; }
        public int AmountPage { get; set; }


        public virtual void AddAuthor(int n)
        {
            AmountAuthor += n;
        }

        public virtual void RemoveAuthor(int n)
        {
            AmountAuthor -= n;
        }

        public void ChangeYear(int year)
        {
            this.Year = year;
        }
        
        protected Book (int Year, int AmountAuthor, string Format, int AmountPage)
        {
            this.Year = Year;
            this.AmountAuthor = AmountAuthor;
            this.Format = Format;
            this.AmountPage = AmountPage;
        }
    }
}
