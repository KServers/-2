//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modesl
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_bill
    {
        public tb_bill()
        {
            this.tb_detail = new HashSet<tb_detail>();
        }
    
        public string billno { get; set; }
        public System.DateTime billdate { get; set; }
        public string suppliername { get; set; }
        public string supplieraddress { get; set; }
        public string department { get; set; }
        public string warehouse { get; set; }
        public string buyer { get; set; }
        public string executor { get; set; }
    
        public virtual ICollection<tb_detail> tb_detail { get; set; }
    }
}
