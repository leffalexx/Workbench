# Лекция 6: Как не нужно писать код. Продолжение

## Критерии качества кода

1. Гибкий
2. Расширяемый
3. Модульный
4. Поддерживаемый
5. Документированный

* Гибкий - значит не ограничивающися текущим применением. Желательно оставить возможность переиспользовать.
* Переиспользование не может быть основным критерием!
* Расширяемый - значит код не имеет внутренних неочевидных ограничений, которые будут мешать в дальнейшем наращивать функционал.
* Модульный - значит каждый функционал в идеале должен без проблем извлекаться из всего кода.
* Поддерживаемый - значит в случае поломки в процессе эволюции кода его легко починить.
* Документирование не настолько очевидно, есть мнение что хороший код самодокументируется.

## Принципы и антипаттерны

* Избегать магических чисел.
* Инициализация пустой строки - через String.Empty, на не " ".
* Копипаст - это плохо. Если можно что-то копипастить, значит лучше создать новый метод и использовать его.
* **DRY** - один из главных принципов, "Don't Repeat Yourself".
* Разумная достаточность. Никогда не надо делать лишнее, если оно не требовалось и не было обосновано.
* **YAGNI** - "You Ain't Gonna Need It".
* **KISS** - "Keep It Simple, Stupid".
* Вся практика написания кода уже написана разработчиком языка (Microsoft для C#), но команды разработки могут привносить что-то новое.
* Необходимо придерживаться Code Convention, используемый в проекте. С изучения Code Convention надо начинать работу с проектом.
* Всегда нужно делать внутреннюю декомпозицию. Чем меньше единица, тем лучше.
* Чем больше методов, тем лучше.
* Много циклов и условий - плохо, замедляет код.
* Нужно писать тестируемый код.
* Всегда внимательно следить за входными данными, особенно если данные вводит юзер. Проверять надо сразу.
* Всегда стоит задаваться вопросом "А можно ли проще?"
* Придерживаться **SOLID** принципов.