using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// OrderStatus category.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// New order.
        /// </summary>
        New,

        /// <summary>
        /// Order in process.
        /// </summary>
        Processing,

        /// <summary>
        /// Order in assemblance.
        /// </summary>
        Assembly,

        /// <summary>
        /// Order is sent.
        /// </summary>
        Sent,

        /// <summary>
        /// Order is delivered.
        /// </summary>
        Delivered,

        /// <summary>
        /// Order is Returned.
        /// </summary>
        Returned,

        /// <summary>
        /// Order is abandoned.
        /// </summary>
        Abandoned 
    }
}
