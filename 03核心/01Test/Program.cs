using System;
/*
1.基于成员变量练习题为人类定义说话、走路、吃饭等方法
2.基于成员变量练习题为学生类定义学习、吃饭等方法
3.定义一个食物类，有名称，热量等特征思考如何和人类以及学生类联系
*/
namespace Study01{
    enum E_Sex{Male,Famale}
    // enum E_CreatrueType{}
    class Creatrue{
        public string Name;
        public E_Sex Sex = E_Sex.Male;   //可以构造时带有默认值

    }
    class Food{
        public string Name = null;
        public float Kll;
        public void ByEat(Creatrue month){
            month 
        }

    }
    class Progarm{
        static void Main(string[] argv){
            Creatrue A = new Creatrue();
            Creatrue B = A;
            B = null;
            
        }
    }
}