using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myOffers.DAL;

namespace myOffers.BLL
{
    public static class CommomBC
    {
        private static Entities _entities;

        public static Entities entities
        {
            get
            {
                if (_entities == null)
                {

                    _entities = new Entities();
                }

                return _entities;

            }
            set { _entities = value; }

        }

    }
}

