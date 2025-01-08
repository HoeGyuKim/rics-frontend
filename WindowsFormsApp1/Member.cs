using System;

namespace WindowsFormsApp1
{
    public class Member
    {
        public long EmployeeNum { get; set; } // 사원 번호
        public string Name { get; set; } // 사용자 이름
        public bool IsManager { get; set; } // 관리자 여부
        public Department Department { get; set; } // 부서 정보
    }

}




