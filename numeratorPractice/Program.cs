using System;
using System.Collections;

namespace numeratorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberCollection mc = new MemberCollection();
            mc.AddMemer(new Member(1, "홍길동"));
            mc.AddMemer(new Member(2, "강감찬"));

            foreach (Member member in mc)
            {
                Console.WriteLine(member.ToString());
            }
        }
    }

    class Member
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("ID is:{0} Name is {1}", Id, Name);
        }
    }

    class MemberCollection : IEnumerable
    {
        private ArrayList ar = new ArrayList();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ar.GetEnumerator();
        }

        public void AddMemer(Member member)
        {
            ar.Add(member);
        }
    }
}