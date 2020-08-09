using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMD_FINAL
{
    class DepthFirstAlgorithm

    {
        public Employee BuildEmployeeGraph()
        {
            Employee A = new Employee("A");
            Employee B = new Employee("B");
            Employee C = new Employee("C");
            A.isEmployeeOf(B);
            A.isEmployeeOf(C);

            Employee D = new Employee("D");
            Employee E = new Employee("E");
            Employee F = new Employee("F");
            Employee G = new Employee("G");
            B.isEmployeeOf(D);
            B.isEmployeeOf(F);
            C.isEmployeeOf(E);
            C.isEmployeeOf(G);

            return A;
        }

        public Employee Search(Employee root, string nameToSearchFor)
        {
            if (nameToSearchFor == root.name)
                return root;

            Employee personFound = null;
            for (int i = 0; i < root.Employees.Count; i++)
            {
                personFound = Search(root.Employees[i], nameToSearchFor);
                if (personFound != null)
                    break;
            }
            return personFound;
        }

        public void Traverse(Employee root)
        {
            Console.WriteLine(root.name);
            for (int i = 0; i < root.Employees.Count; i++)
            {
                Traverse(root.Employees[i]);
            }
        }
    }


}

