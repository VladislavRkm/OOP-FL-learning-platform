/*
Идентификатор сертификата (CertificateId)
Идентификатор пользователя, который его получает (UserId)
Идентификатор курса, по которому выдаётся сертификат (CourseId)
Процент выполненной работы по курсу (PercentOfPassed) 
*/

public class Certificate
{
    public int CertificateId {  get; set; }
    public int UserId { get; set; }
    public int CourseId { get; set; }
    public int PercentOfPassed { get; set; }
}