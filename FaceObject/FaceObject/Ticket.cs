using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceObject
{
    public class Ticket
    {
        //构造函数
        public Ticket(double distance)
        {
            //接收的距离不能给属性，因为属性是只读的  所以这里直接给字段赋值
            //this.Ditance = distance;
            this._distance = distance;
        }


        private double _distance;

        //只读属性
        public double Ditance
        {
            get {
                if (_distance<0)
                {
                    return _distance = 100;
                }
                return _distance; }
        }

        private double _price;

        public double Price
        {
            //这是一个天然的方法  不用再写一个方法去实现不同公里价格的判断
            get {
                if (_distance>0&&_distance<=100)
                {
                    //返回的值要思考
                    return _distance * 1.0;
                }
                else if (_distance>100&&_distance<=200)
                {
                    return _distance * 0.95;
                }
                else if(_distance>200&&_distance<=300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
                /*return _price;*/ }
        }

        
        public void GetPrice()
        {
            Console.WriteLine("{0}公里,价格是{1}元",this.Ditance,this.Price);
        }
    }
}
