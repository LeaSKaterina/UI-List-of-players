# Тестовое задание про UI и клиент-серверное взаимодействие в Unity

## Условие
### Задача
Необходимо получить на сервере информацию об игроках и отобразить вертикальный прокручиваемый список. Где каждая ячейка - это информация об игроке: аватарка, имя и количество очков. Игроков нужно отсортировать по количеству очков. Визуал не важен.
### Главные требования:
* На любом вертикальном разрешении экрана интерфейс должен тянуться хорошо
* Решить проблему с большим количеством ячеек. (Из-за создания большого количества элементов UI в списке, фпс на слабых устройствах будет сильно проседать. Разрешается использовать сторонние библиотеки, плагины)

## Комментарии к решению 
Был использован Recyclable Scroll Rect (ссылки [https://assetstore.unity.com/packages/tools/gui/recyclable-scroll-rect-optimized-list-grid-view-178560](на него в assetstore) и [https://github.com/MdIqubal/Recyclable-Scroll-Rect](на исходники на github)).
Данные про прользователей считываются из файла Assets/data.json, содержимое файла взято из примера, который шел вместе с тестовым.
