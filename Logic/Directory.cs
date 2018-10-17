using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Directory:Book,IEdition
    {
        public string Binding { get; set; }//переплет(жесткий или мягкий)
        public string Name { get; set; }

        public Directory(int Year, int AmountAuthor, string Format, int AmountPage,string Binding, string Name):base(Year, AmountAuthor, Format, AmountPage)
        {
            this.Binding = Binding;
            this.Name = Name;
        }

        public override void AddAuthor(int n)
        {
            AmountAuthor += n;
        }

        public override void RemoveAuthor(int n)
        {
            AmountAuthor -= n;
        }

        public void ChangeName(string NewName)
        {
            this.Name = NewName;
        }

        public void SetBinding(string Binding)
        {
            this.Binding = Binding;
        }

        public override string ToString()
        {
            return "Name:"+Name.ToString()+" "+"Binding:"+Binding.ToString()+" "+"Year:"+Year.ToString()+" "+"Amount author:"+AmountAuthor.ToString()+" "+"Format:"+Format.ToString()+" "+"Amount page:"+AmountPage.ToString()+";"+ Environment.NewLine;
        }
    }
}


