using Newtonsoft.Json;
using System;

namespace WindowsFormsApp1
{
    public class ReconditionedListItem
    {
        public long id { get; set; } // 등록번호
        public string formattedId => id.ToString("D8"); // 8자리 형식으로 표시
        public DateTime date { get; set; } // 완료일자
        public long productNum { get; set; } // 자재번호
        public string productName { get; set; } // 자재명
        public string serialNum { get; set; } // 시리얼번호
        public string workerName { get; set; } // 작업자 이름
        public string middleManagerName { get; set; } // 관리자 이름
        public string departmentName { get; set; } // 발생부서
        public int approvalStatus { get; set; } // 결재 상태

        public string approvalStatusText
        {
            get
            {
                return approvalStatus switch
                {
                    1 => "결재 대기",
                    2 => "1차 검토 완료",
                    3 => "승인",
                    4 => "반려",
                    5 => "삭제 신청",
                    6 => "삭제 1차 검토 완료",
                    _ => "알 수 없음",
                };
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
        public long id { get; set; }
        public string formattedId
        {
            get
            {
                return id.ToString("D8"); // 8자리 포맷 (앞에 0 추가)
            }
        }
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
                    return "결재 대기";
                else if (approvalStatus == 2)
                    return "1차 검토 완료";
                else if (approvalStatus == 3)
                    return "최종 승인";
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

    public class approvalListItem
    {
        public long id { get; set; }
        public string FormattedId
        {
            get
            {
                return id.ToString("D8"); // 8자리 포맷 (앞에 0 추가)
            }
        }
        public int productNum { get; set; }
        public string productName { get; set; }
        public string date { get; set; }
        public string serialNum { get; set; }
        public string workerName { get; set; }
        public string middleManagerName { get; set; }
        public string lastManagerName { get; set; }
        public DateTime? submitTime { get; set; }
        public DateTime? firstApprovalTime { get; set; }
        public DateTime? lastApprovalTime { get; set; }

    }
}


