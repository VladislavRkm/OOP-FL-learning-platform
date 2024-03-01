# Сущности

### Сертификат(Certificate):

Идентификатор сертификата (CertificateId)
Идентификатор пользователя, который его получает (UserId)
Идентификатор курса, по которому выдаётся сертификат (CourseId)Процент выполненной работы по курсу (PercentOfPassed) 

### Курс(Course): 

Идентификатор(CourseId)
Название(Title)
Описание(Description)
Идентификатор автора (AuthorId)
Код языка (LanguageCode)
Дата создания курса (CreatedDate)
Уровень сложности(DifficultyLevel)

### Урок(Lesson): 

Идентификатор(LessonId)
Название(Title)
Материал урока(Content)
Идентификатор Курса, к которому относится урок (CourseId)

### Пройденный урок(LessonPassed):

Идентификатор сданного урока (LessonPassedId)
Идентификатор урока (LessonId)
Идентификатор пользователя, который выполнил урок (UserId)
Дата, когда пользователь закончил урок (LessonPassedDate)

### Пользователь(User):

Идентификатор(UserId)
Имя(FirstName)
Фамилия(LastName)
Электронная почта(Email)
Пароль(Password)
Дата регистрации(RegistrationDate)
