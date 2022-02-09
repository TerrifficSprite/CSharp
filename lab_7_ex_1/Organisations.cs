using System.Collections;
using System.Collections.Generic;

namespace lab_7_ex_1
{
    public class Organisations : IEnumerable
    {
        private Organization[] _organization;

        public Organization[] Organization
        {
            get => _organization;
            set => _organization = value;
        }

        public Organisations(Organization[] organizationsList)
        {
            _organization = organizationsList;
        }
        
        public class SortByEmployees : IComparer<Organization>
        {
            public int Compare(Organization? x, Organization? y)
            {
                if (x.Employees > y.Employees)
                    return 1;
                if (x.Employees < y.Employees)
                    return -1;
                return 0;
            }
        }
        
        public class SortBySuccessRate : IComparer<Organization>
        {
            public int Compare(Organization? x, Organization? y)
            {
                if (x.SuccessRate > y.SuccessRate)
                    return 1;
                if (x.SuccessRate < y.SuccessRate)
                    return -1;
                return 0;
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            return _organization.GetEnumerator();
        }
    }
}