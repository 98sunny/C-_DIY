using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02Assignment1.Business
{
    class Student:IEquatable<Student>{
        protected string name;
        protected string id;
        double score, maxScore;
        protected string assignmentID;

        public String Name {
            set { name = value; }
            get { return name; }
        }

        public bool Equals(Student other)
        {
            throw new NotImplementedException();
        }
    }
}
