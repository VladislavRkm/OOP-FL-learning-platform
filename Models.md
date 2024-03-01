# OOP-FL-learning-platform

Эта строчка добавлена в VS code

�������� ������� ��

����������(Certificate):

������������� ����������� (CertificateId)
������������� ������������, ������� ��� �������� (UserId)
������������� �����, �� �������� ������� ���������� (CourseId)
������� ����������� ������ �� ����� (PercentOfPassed) 

����(Course): 

�������������(CourseId)
��������(Title)
��������(Description)
������������� ������ (AuthorId)
��� ����� (LanguageCode)
���� �������� ����� (CreatedDate)
������� ���������(DifficultyLevel)

����(Lesson): 
 
�������������(LessonId)
��������(Title)
�������� �����(Content)
������������� �����, � �������� ��������� ���� (CourseId)

���������� ����(LessonPassed):

������������� �������� ����� (LessonPassedId)
������������� ����� (LessonId)
������������� ������������, ������� �������� ���� (UserId)
����, ����� ������������ �������� ���� (LessonPassedDate)

������������(User):

�������������(UserId)
���(FirstName)
�������(LastName)
����������� �����(Email)
������(Password)
���� �����������(RegistrationDate)