using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class HonorQueue : Queue<Department>
    {
        public void Enqueue(Dictionary<string, int> pepole)
        {
            foreach (var person in pepole)
            {
                string name = person.Key;
                int age = person.Value;

                var department = this.FirstOrDefault(depr => depr.age == age);
                if (department != null)
                {
                    department.names.Add(name);
                }
                else
                {
                    department = new Department(age);
                    department.names.Add(name);
                    insertInOrder(department);

                }
            }
        }

        public void insertInOrder(Department department)
        {
            List<Department> list = this.ToList();
            list.Add(department);

            list = list
                .OrderByDescending(be => be.age).ToList();

            this.Clear();

            foreach (Department deper in list)
            {
                base.Enqueue(deper);
            }
        }

    }
}
