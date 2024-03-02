# OOP-FL-learning-platform
***
## 18. ������-��������� ��� �������� ����������� ������
![](OIG3.jpg)
***
__�������:__ ����������� ������ ���������, ����� ������ �������, ��������� ������ ����������,
�������� ��������� ����������, ��������� �������� ��������
***
## �������� ��������:

```
public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string Role { get; set; }
}
```
```
public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string LanguageLevel { get; set; }
    public int DurationInWeeks { get; set; }
    public string Language { get; set; }
    public User Teacher { get; set; }
    public List<Lesson> Lessons { get; set; }
}
```
```
public class Lesson
{
    public int LessonId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set; }
    public Course RelatedCourse { get; set; }
    public bool LessonIsPassed { get; set; }
}
```
```
public class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Course Course { get; set; }
    public string Text { get; set; }
    public DateTime ReviewDate { get; set; }
}
```
```
public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public List<Course> Courses { get; set; }
}
```
## ERD:
![](EngLeash.drawio.png)
***
## ������ ��� ������ � �������, �������, ���������� � ���������������.
## �����������, ����������� � �������� �������

### **����������� ������������ - POST /api/signup/**

```json
request:
{
    "firstName": "Svyatozar",
    "lastName": "Kapibarov",
    "email": "sobakasutulaya@gmail.com",
    "password": "123456"
}

response:
{
    "status": "ok"
}
```

### **����������� ������������ - POST /api/login/**

```json
request:
{
    "email": "sobakasutulaya@gmail.com",
    "password": "123456"
}

response:
{
    "status": "ok"
}
```

### **��������� ���������� � ������������ - GET /api/users/user_id/**

```json
request:
{
    "userId": 1
}

response:
{
    "userId": 1,
    "firstName": "Svyatozar",
    "lastName": "Kapibarov",
    "email": "sobakasutulaya@gmail.com",
    "registrationDate": "2021-01-01"
}
```

### **��� ������� - GET /api/my_profile/**

```json
request:
{
}

response:
{
    "userId": 1,
    "firstName": "Svyatozar",
    "lastName": "Kapibarov",
    "email": "sobakasutulaya@gmail.com",
    "registrationDate": "2021-01-01"
}
```

### **��� ����� - GET /api/my_profile/my_courses/**

```json
request:
{
}

response:
{
    "courses": [
        {
            "courseId": 1,
        },
        {
            "courseId": 2,
        }
    ]
}
```

### **��� ����������� - GET /api/my_profile/my_certificates/**

```json
request:
{
}

response:
{
    "certificates": [
        {
            "courseId": 1,
        },
        {
            "courseId": 2,
        }
    ]
}
```

### **��� ��������� ����� - GET /api/my_profile/my_authorship/**

```json
request:
{
}

response:
{
    "courses": [
        {
            "courseId": 1,
        },
        {
            "courseId": 2,
        }
    ]
}
```


### **�������������� ������� - PUT /api/my_profile/edit_profile/**

```json
request:
{
    "firstName": "Svyatozar",
    "lastName": "Kapibarov",
    "email": "anothersobakasutulaya@gmail.com",
    "password": "12345aboba"
}

response:
{
    "status": "ok"
}
```

### **�������� ������� - DELETE /api/my_profile/delete_profile/**

```json
request:
{
}

response:
{
    "status": "ok"
}
```


## ����� ������, ������ � ���������

### **��������� ������ ������ - GET /api/courses/**

```json
request:
{
}

response:
{
    "courses": [
        {
            "courseId": 1,
            "title": "Course 1",
            "description": "Description 1",
            "authorId": 1,
            "languageCode": "en",
            "createdDate": "2021-01-01",
            "difficultyLevel": "intermediate"
        },

        {
            "courseId": 2,
            "title": "Course 2",
            "description": "Description 2",
            "authorId": 2,
            "languageCode": "kz",
            "createdDate": "2021-01-01",
            "difficultyLevel": "advanced"
        }
    ]
}
```

### **��������� ����� �� �������� - GET /api/courses/course_id**

```json
request:
{
    "title": "Course 1"
}

response:
{
    "courseId": 1,
    "title": "Course 1",
    "description": "Description 1",
    "authorId": 1,
    "languageCode": "en",
    "createdDate": "2021-01-01",
    "difficultyLevel": "intermediate"
}
```

### **��������� ����� �� id - GET /api/courses/course_id**

```json
request:
{
    "courseId": 1
}

response:
{
    "courseId": 1,
    "title": "Course 1",
    "description": "Description 1",
    "authorId": 1,
    "languageCode": "en",
    "createdDate": "2021-01-01",
    "difficultyLevel": "intermediate"
}
```

### **��������� ����� �� id - GET /api/lessons/lesson_id**

```json
request:
{
    "id": 1
}

response:
{
    "lessonId": 1,
    "title": "Lesson 1",
    "content": "Content 1",
    "courseId": 1
}
```

### **��������� ������ ������ �� id ����� - GET /api/lessons/course_id**

```json
request:
{
    "courseId": 1
}

response:
{
    "lessons": [
        {
            "lessonId": 1,
        },

        {
            "lessonId": 2,
        }
    ]
}
```

### **��������� ������ ���������� ������ �� id ������������ - GET /api/lessons/user_id**

```json
request:
{
    "userId": 1
}

response:
{
    "lessons": [
        {
            "lessonId": 1,
        },

        {
            "lessonId": 2,
        }
    ]
}
```

### **��������� ������ ��������� ����� - GET /api/courses/course_id/students/**

```json
request:
{
}

response:
{
    "students": [
        {
            "userId": 1,
        },
        {
            "userId": 2,
        }
    ]
}
```

### **��������� ������ ����� - GET /api/courses/course_id/author/**

```json
request:
{
}

response:
{
    "author": {
        "userId": 1,
    }
}
```

### **��������� ������ ������ ������ - GET /api/courses/author_id/courses**

```json
request:
{
    "authorId": 1
}

response:
{
    "courses": [
        {
            "courseId": 1,
        },
        {
            "courseId": 2,
        }
    ]
}
```

## �������� � �������������� ������

### **�������� ����� - POST /api/courses/add_course**

```json
request:
{
    "title": "Course 1",
    "description": "Description 1",
    "authorId": 1,
    "languageCode": "en",
    "difficultyLevel": "intermediate"
}

response:
{
    "status": "ok"
}
```

### **�������������� ����� - PUT /api/courses/course_id/edit_course**

```json
request:
{
    "courseId": 1,
    "title": "Course 1",
    "description": "Changed description 1",
    "authorId": 1,
    "languageCode": "en",
    "difficultyLevel": "intermediate"
}

response:
{
    "status": "ok"
}
```

### **�������� ����� - DELETE /api/courses/course_id/delete_course**

```json
request:
{
    "courseId": 1
}

response:
{
    "status": "ok"
}
```


### **�������� ����� �� ����� - POST /api/courses/course_id/lessons/add_lesson**

```json
request:
{
    "title": "Lesson 1",
    "content": "Content 1",
    "courseId": 1
}

response:
{
    "status": "ok"
}
```

### **�������������� ����� - PUT /api/courses/course_id/lessons/edit_lesson**

```json
request:
{
    "lessonId": 1,
    "title": "Lesson 1",
    "content": "Changed content 1",
    "courseId": 1
}

response:
{
    "status": "ok"
}
```

### **�������� ����� - DELETE /api/courses/course_id/lessons/delete_lesson**

```json
request:
{
    "lessonId": 1
}

response:
{
    "status": "ok"
}
```

## �������� �� �����

### **����������� �� ���� - POST /api/courses/course_id/apply**

```json
request:
{
    "courseId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```

### **���������� � ����� - DELETE /api/courses/course_id/leave**

```json
request:
{
    "courseId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```


### **����������� ����� - POST /api/lessons/lesson_id/submit**

```json
request:
{
    "lessonId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```

### **�������� ����������� - GET /api/courses/course_id/certificates/download_certificate**

```json
request:
{
    "courseId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```

## ���������� ���������� �� ��������� �����


### **���������� �������� �� ���� - POST /api/courses/course_id/students/add_student**

```json
request:
{
    "courseId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```

### **�������� �������� � ����� - DELETE /api/courses/course_id/students/delete_student**

```json
request:
{
    "courseId": 1,
    "userId": 1
}

response:
{
    "status": "ok"
}
```

### **������ ����������� - POST /api/courses/course_id/certificates/give_certificate**

```json
request:
{
    "courseId": 1,
    "userId": 1,
    "percentOfPassed": 100
}

response:
{
    "status": "ok"
}
```
***