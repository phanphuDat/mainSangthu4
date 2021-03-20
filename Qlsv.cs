using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_HuongDoiTuong
{
    public class Qlsv
    {
        public Sv[] listSv{get; set;}
        public int n{get; set;}

        public Qlsv(){
            listSv=null;
            n=0;
        }
        
        public void Add(Sv sv) {
            if(n==0)
            {
                listSv = new Sv[n+1];   //khởi tạo mảng listSv có độ dài là n+1
                listSv[n] = sv;
            }
            else{
                Sv[] temp = new Sv[n]; //khởi tạo mảng temp có độ dài là n 
                for(int i=0; i<n; ++i) {
                    temp[i] = listSv[i];    //thêm các phần tử vào mảng temp
                }
                listSv = new Sv[n+1];   //khởi tạo mảng listSV có độ dài là n+1
                for(int i=0; i<n; ++i) {
                    listSv[i] = temp[i];
                }
                listSv[n] = sv;
            }
            n++;
        }

        public override string ToString() {
            string r = "";
            foreach( Sv i in listSv) {
                r += i.ToString() + "\n";
            }
            return r;
        }

        // public void InsertSv(Sv sv, int index){

        // }

        // public int indexOf(Sv sv) {
        //     int index = -1;
        //     return index;
        // }

        // public void RemoveAt(int index) {

        // }

        // public void Remove(Sv sv) {

        // }

        // public void Update(int mssv) {

        // }

        // public void sort(){
            
        // }
    }
}