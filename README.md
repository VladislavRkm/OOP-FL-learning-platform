# OOP-FL-learning-platform

## Методы API

Методы для работы с курсами, студентами и преподавателями.





### Получение списка курсов - **GET /api/courses/**

```json
request:
{
    "key": "all"
}

response:
 {
    "courses": [
        {
            "id": 1,
            "name": "Course 1",
            "description": "Description 1",
            "teachers": [
                {
                    "id": 1,
                    "name": "Teacher 1"
                },
                {
                    "id": 2,
                    "name": "Teacher 2"
                }
            ],
            "students": 14
        },
        {
            "id": 2,
            "name": "Course 2",
            "description": "Description 2",
            "teachers": [
                {
                    "id": 3,
                    "name": "Teacher 3"
                },
                {
                    "id": 4,
                    "name": "Teacher 4"
                }
            ],
            "students": 25
        }
    ]
}

```





### **Получение курса по названию - GET /api/courses/id**

```json
request:
{
    "key": "name",
    "name": "Course 1"
}

response:
{
    "id": 1,
    "name": "Course 1",
    "description": "Description 1",
    "teachers": [
        {
            "id": 1,
            "name": "Teacher 1"
        },
        {
            "id": 2,
            "name": "Teacher 2"
        }
    ],
    "students": 14
}
```





### **Получение курса по id - GET /api/courses/id**

```json
request:
{
    "key": "id",
    "id": 1
}

response:
{
    "id": 1,
    "name": "Course 1",
    "description": "Description 1",
    "teachers": [
        {
            "id": 1,
            "name": "Teacher 1"
        },
        {
            "id": 2,
            "name": "Teacher 2"
        }
    ],
    "students": 14
}
```





### **Получение списка студентов курса - GET /api/courses/id/students/**

```json
request:
{
    "key": "id",
    "id": 1
}

response:
{
    "students": [
        {
            "id": 1,
            "name": "Student 1"
        },
        {
            "id": 2,
            "name": "Student 2"
        }
    ]
}
```





### **Получение списка преподавателей курса - GET /api/courses/id/teachers/**

```json
request:
{
    "key": "id",
    "id": 1
}

response:
{
    "teachers": [
        {
            "id": 1,
            "name": "Teacher 1"
        },
        {
            "id": 2,
            "name": "Teacher 2"
        }
    ]
}
```





### **Получение списка курсов студента - GET /api/students/id/courses/**

```json
request:
{
    "student_id": 1
}

response:
{
    "courses": [
        {
            "id": 1,
            "name": "Course 1",
            "description": "Description 1",
            "teachers": [
                {
                    "id": 1,
                    "name": "Teacher 1"
                },
                {
                    "id": 2,
                    "name": "Teacher 2"
                }
            ],
            "students": 14
        },
        {
            "id": 2,
            "name": "Course 2",
            "description": "Description 2",
            "teachers": [
                {
                    "id": 3,
                    "name": "Teacher 3"
                },
                {
                    "id": 4,
                    "name": "Teacher 4"
                }
            ],
            "students": 25
        }
    ]
}
```





### **Получение списка курсов преподавателя - GET /api/teachers/id/courses/**

```json
request:
{
    "teacher_id": 1
}

response:
{
    "courses": [
        {
            "id": 1,
            "name": "Course 1",
            "description": "Description 1",
            "teachers": [
                {
                    "id": 1,
                    "name": "Teacher 1"
                },
                {
                    "id": 2,
                    "name": "Teacher 2"
                }
            ],
            "students": 14
        },
        {
            "id": 2,
            "name": "Course 2",
            "description": "Description 2",
            "teachers": [
                {
                    "id": 3,
                    "name": "Teacher 3"
                },
                {
                    "id": 4,
                    "name": "Teacher 4"
                }
            ],
            "students": 25
        }
    ]
}
```





### **Добавление студента на курс - POST /api/courses/id/students/**

```json
request:
{
    "course_id": 1,
    "student_id": 1
}

response:
{
    "status": "ok"
}
```





### **Добавление преподавателя на курс - POST /api/courses/id/teachers/**

```json
request:
{
    "course_id": 1,
    "teacher_id": 1
}

response:
{
    "status": "ok"
}
```





### **Удаление студента с курса - DELETE /api/courses/id/students/**

```json
request:
{
    "course_id": 1,
    "student_id": 1
}

response:
{
    "status": "ok"
}
```





### **Удаление преподавателя с курса - DELETE /api/courses/id/teachers/**

```json
request:
{
    "course_id": 1,
    "teacher_id": 1
}

response:
{
    "status": "ok"
}
```





### **Добавление курса - POST /api/courses/**

```json
request:
{
    "name": "Course 1",
    "description": "Description 1"
}

response:
{
    "status": "ok"
}
```





### **Удаление курса - DELETE /api/courses/id/**

```json
request:
{
    "id": 1
}

response:
{
    "status": "ok"
}
```





### **Редактирование курса - PUT /api/courses/id/**

```json
request:
{
    "id": 1,
    "name": "Course 1",
    "description": "Description 1"
}

response:
{
    "status": "ok"
}
```





### **Регистрация пользователя - POST /api/students/**

```json
request:
{
    "name": "Svyatozar Kapibarov",
    "role": "student",
    "email": "aboba@gmail.com",
    "password": "abobaaboba228"

}

response:
{
    "status": "ok"
}
```





### **Авторизация пользователя - POST /api/students/login/**

```json
request:
{
    "email": "aboba@gmail.com",
    "password": "abobaaboba228"
}

response:
{
    "status": "ok"
}
```





### **Получение информации о пользователе - GET /api/users/id/**

```json
request:
{
    "id": 1
}

response:
{
    "id": 1,
    "name": "Svyatozar Kapibarov",
    "role": "student",
    "email": "aboba@gmail.com"
}

```

я думаю хватит

мяу






