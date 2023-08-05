# .Net-Application-Example
  
  (ENG)
  
  Sample web application built using ASP.NET Core technologies. This project demonstrates a simple CRUD (Create, Read, Update, Delete) functionality for working with data. The project uses the principles of Separation of Concerns and Dependency Inversion.

Technologies:

ASP.NET Core, Entity Framework Core, AutoMapper

The main components of the architecture include:

-Models: This part defines data models representing entities in the database such as companies, leaders, employees, orders, etc. Models contain only properties and do not have any business logic.

-Entities: This is the data access layer that defines the entity classes corresponding to the database tables. This layer uses Entity Framework Core to perform CRUD operations on the database.

-Services: Services provide the business logic and core functionality of the application. They are interfaces that define operations to be performed on data and their implementations. Services are used to interact with the Entity Framework and other components.

-Controllers: Controllers are part of the presentation layer and provide an API for user interaction. They accept HTTP requests, call the appropriate service methods, and return HTTP responses.
  



  (RU)
  
  Пример веб-приложения, созданного с использованием технологий ASP.NET Core. Этот проект демонстрирует простой CRUD (Create, Read, Update, Delete) функционал для работы с данными. 
  В проекте применены принципы разделения ответственности (Separation of Concerns) и инверсии зависимостей (Dependency Inversion). 


Технологии:

ASP.NET Core, Entity Framework Core, AutoMapper

Основные компоненты архитектуры включают:

-Models: В этой части определены модели данных, представляющие сущности в базе данных, такие как компании, лидеры, сотрудники, заказы и т.д. Модели содержат только свойства и не имеют никакой бизнес-логики.

-Entities: Это слой доступа к данным, в котором определены классы сущностей, соответствующие таблицам базы данных. В этом слое используется Entity Framework Core для выполнения операций CRUD с базой данных.

-Services: Сервисы предоставляют бизнес-логику и основную функциональность приложения. Они представляют собой интерфейсы, определяющие операции, выполняемые над данными, и их реализации. Сервисы используются для взаимодействия с Entity Framework и другими компонентами.

-Controllers: Контроллеры являются частью слоя представления и предоставляют API для взаимодействия с пользователем. Они принимают HTTP-запросы, вызывают соответствующие методы сервисов и возвращают HTTP-ответы.
