//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddrBook.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailInfo
    {
        public int ContactsId { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public Nullable<int> GroupId { get; set; }
    
        public virtual ContactsInfo ContactsInfo { get; set; }
        public virtual GroupInfo GroupInfo { get; set; }
    }
}
