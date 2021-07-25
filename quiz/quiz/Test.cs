using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    [Serializable]
    class Test
    {
        [DataMember]
        public string question; // поле тип теста
        [DataMember]
        public int index;
        [DataMember]
        public int truefalse1;
        [DataMember]
        public int truefalse2;
        [DataMember]
        public int truefalse3;
        [DataMember]
        public int truefalse4;
        [DataMember]
        public string answer1;
        [DataMember]
        public string answer2;
        [DataMember]
        public string answer3;
        [DataMember]
        public string answer4;
        [DataMember]
        public string img;


        public Test() { } 

      
    }
}
