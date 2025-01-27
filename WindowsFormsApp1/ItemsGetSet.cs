using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1
{
    public class ReconditionedListItem
    {
        public long id { get; set; }
        public DateTime date { get; set; }
        public long? productNum { get; set; }
        public string productName { get; set; }
        public string serialNum { get; set; }
        public string workerName { get; set; }
        public string middleManagerName { get; set; }
        public string departmentName { get; set; }
        public int approvalStatus { get; set; }

        public string approvalStatusText
        {
            get
            {
                if (approvalStatus == 1)
                    return "상신";
                else if (approvalStatus == 2)
                    return "1차 검토 완료";
                else if (approvalStatus == 3)
                    return "승인";
                else if (approvalStatus == 4)
                    return "반려";
                else if (approvalStatus == 5)
                    return "삭제 신청";
                else if (approvalStatus == 6)
                    return "삭제 1차 검토 완료";
                else return "알 수 없음";
            }
        }
    }

    public class SimpleReconditioned
        {
            public int productNum { get; set; }
            public string productName { get; set; }
        }


        public class SimpleMembers
        {
            
            public string Name { get; set; }
            [JsonProperty("employeeNum")]   
            public int EmployeeNum { get; set; }
            public Department Department { get; set; }
        }


        public class Department
        {
            public string DepartmentName { get; set; }
        }

    public class DetailDTO
    {
        public long Id { get; set; }
        public int productNum { get; set; }
        public string productName { get; set; }
        public string date { get; set; }
        public string serialNum { get; set; }
        public string workerName { get; set; }
        public string middleManagerName { get; set; }
        public string lastManagerName { get; set; }
        public string departmentName { get; set; }
        public string memo { get; set; }
        public string contactNumber { get; set; }
        public int approvalStatus { get; set; }
        public string approvalStatusText
        {
            get
            {
                if (approvalStatus == 1)
                    return "상신";
                else if (approvalStatus == 2)
                    return "1차 검토 완료";
                else if (approvalStatus == 3)
                    return "승인";
                else if (approvalStatus == 4)
                    return "반려";
                else if (approvalStatus == 5)
                    return "삭제 신청";
                else if (approvalStatus == 6)
                    return "삭제 1차 검토 완료";
                else return "알 수 없음";
            }
        }

        // Nullable DateTime 사용
        public DateTime? submitTime { get; set; }
        public DateTime? firstApprovalTime { get; set; }
        public DateTime? lastApprovalTime { get; set; }
    }
}


