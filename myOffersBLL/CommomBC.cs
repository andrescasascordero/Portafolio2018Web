using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myOffersDAL;

namespace myOffersBLL
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

        }


    }
}
