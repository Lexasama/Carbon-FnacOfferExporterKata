using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OfferExporter
{
    public class Offer
    {
        [IgnoreDataMember]
        public int Id { get; set; }

        [DataMember(Name = "seller")]
        public string Company { get; set; }

        [DataMember(Name = "price")]
        public decimal Price { get; set; }

        [DataMember(Name = "reducedPrice")]
        public decimal? ReducedPrice { get; set; }

        [DataMember(Name = "qty")]
        public int Quantity { get; set; }
    }
}
