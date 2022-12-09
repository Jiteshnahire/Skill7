using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject7.OOPs
{
    class Book
    {

        int id;
        string name;
        string author;
        int price;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Author
        {
            set
            {
                author = value;
            }
            get
            {
                return author;
            }
        }

        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

    }
}
    