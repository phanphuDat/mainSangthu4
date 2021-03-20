using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_HuongDoiTuong
{
    public class Sv
    {
        public int MSSV{get; set;}
        public String tenSv{get; set;}
        public override string ToString()
        {
            return "Ma so sinh vien:" + MSSV +" , "+" Ten sinh vien: " +tenSv;
        }
    }
}