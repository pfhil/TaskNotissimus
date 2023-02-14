# TaskNotissimus

Решенное тестовое от компании ООО НОТИССИМУС

<details>
  <summary>Текст задания</summary>

  Написать одностраничный веб проект на ASP.NET Core.

Алгоритм работы метода контроллера

1. При открытии страницы должна подгружаться информация из XML файла. Файл доступен по URL: http://partner.market.yandex.ru/pages/help/YML.xml

2. После обработки файла из полученного списка offers найти offer с Id = 12344

3. Сохранить offer в базу данных SQL SERVER через Entity. Если уже есть offer с таким Id, то сохранять не нужно.

4. Отобразить offer на View. Верстка bootstrap.

</details>

# Установка и настройка

## Предварительные требования

1. Удостоверьтесь, что на компьютере установлен пакет SDK для .NET 7.0. Скачать его можно с официального сайта https://dotnet.microsoft.com/en-us/download/dotnet/7.0
2. Удостоверьтесь, что на компьютере установлен MS SQL Server. Скачать его можно с официального сайта https://www.microsoft.com/en-us/sql-server/sql-server-downloads

## Установка и запуск

<details>
  <summary>Используя терминал</summary>

1. Клонируйте приложение с помощью команды git:
```
git clone https://github.com/pfhil/TaskNotissimus.git
```
2. Перейдите в каталог проекта с помощью командной строки:
```
cd [repository]
```
3. Восстановите пакеты NuGet, выполнив следующую команду:
```
dotnet restore
```
4. Затем, при помощи проводника, в папке репозитория откройте папку TaskNotissimus.Web и откройте файл appsettings.json и найдите раздел «ConnectionStrings». Измените значение "DefaultConnection" строкой подключения для вашей базы данных и сохраните файл.
5. При помощи командной строки откройте папку TaskNotissimus.Infrastructure и Создайте базу данных, выполнив следующую команду:
```
dotnet ef --startup-project ../TaskNotissimus.Web database update
```
<details>
  <summary>Возможнная ошибка на этом этапе</summary>
  
  После выполнения команды dotnet ef database update вы можете столкнуться со следующей ошибкой:
  
  ```
  Не удалось выполнить, так как не найдены указанная команда или указанный файл.
Возможные причины:
  * вы неправильно набрали встроенную команду dotnet;
  * вы планировали выполнить программу .NET, однако dotnet-ef не существует;
  * вы хотели запустить глобальное средство, но по указанному в PATH пути не удалось найти исполняемый файл с префиксом dotnet, имеющий такое имя.
  ```
  Для ее решения потребуется выполнить следующую команду:
  ```
  dotnet tool install --global dotnet-ef
  ```
  Затем повторите команду:
  ```
  dotnet ef --startup-project ../TaskNotissimus.Web database updat
  ```
</details>

6. Чтобы запустить приложение - при помощи командной строки откройте папку TaskNotissimus.Web и выполните команду:
```
dotnet run
```
В последующих строках должен быть отображен примерно следующий текст:
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5009
```
Это означает, что вы можете открыть в браузере ссылку http://localhost:5009 (ссылка может быть другая! используйте ту которая отобразилась у вас на терминале) и получить доступ к функциям приложения.

7. Теперь ваше приложение запущено и успешно подключено к базе данных.

Для остановки работы приложения вы можете использовать в терминале в котором вы запускали программу сочетание клавиш Ctrl+C или закрыть сам терминал

</details>

<details>
  <summary>Используя Visual Studio 2022</summary>
  
1. Скачайте архив проекта (Кнопка Code->Download ZIP)
2. Разархивируйте его
3. Откройте каталог TaskNotissimus-master и в нем при помощи Visual Studio 2022 откройте TaskNotissimus.sln

Далее используя Visual Studio 2022

4. Откройте папку Presentation, откройте проект TaskNotissimus.Web, откройте файл appsettings.json и найдите раздел «ConnectionStrings». Измените значение "DefaultConnection" строкой подключения для вашей базы данных и сохраните файл.
5. Назначте в качестве запускаемого проекта по умолчанию - проект TaskNotissimus.Web. Для этого, нажмите правой кнопкой мыши на проект TaskNotissimus.Web и в выпадающем меню нажмите кнопку "Set as Startup Project"
6. Откройте Package Manager Console (Если нету - в меню сверху Tools->NuGet Package Manager->Package Manager Console)
7. В окне Package Manager Console для параметра "Defalut project" выберите значение "TaskNotissimus.Infrastructure"
8. Создайте базу данных командой:
```
update-database
```

9. Запустите проект (кнопка Start в меню сверху или F5 на клавиатуре)

У вас должны были открыться терминал и браузер с функциями приложения. Если браузер не открылся, то в терминале должны быть отображены примерно следующие строки:

```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7003
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5009
```

Это значит, что перейдя по ссылке https://localhost:7003 или http://localhost:5009 (ссылки могут быть другие! используйте те которые отобразились у вас на терминале) в браузере вы сможете воспользоваться функциями приложения

10. Теперь ваше приложение запущено и успешно подключено к базе данных.

Для остановки работы приложения вы можете использовать в терминале, который запустился вместе с программой, сочетание клавиш Ctrl+C или закрыть сам терминал или в Visual Studio 2022 нажать кнопку Stop в меню сверху

</details>

# Используемые технологии

- ASP.NET 7
- ASP.NET MVC
- Entity Framework
- MS SQL Server
- AutoMapper
- MediatR
