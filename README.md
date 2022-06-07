# TestEventService

### Дублирование основного коммента из EventService

Учитывая, что это тестовый сервис - я не посчитал нужным выделять под него отдельный интерфейс.   
В реальном проекте, скорее всего, это был бы не MonoBehaviour, а ScriptableObject или даже "простой" обьект,  
доступный через подходящий для этого интерфейс,может быть через какой - то менеджер сервисов  

Также я не заморачивался с namespace, но в реальном проекте, подобный сервис и его компоненты,  
стоило бы вынести в отдельные пространства имен, уникальные в рамках проекта(нескольких проектов)  

Интерфейсы названы максимально просто, в реальном проекте они могли бы называться сложнее или быть упакованы   
в специфичные пространства имен(IStorage, например, крайне общее название),  
может быть отдельные для каждой подзадачи(хранения,отсылки).  

Также, я сознательно не использую структуры в данном случае - с одной стороны их лучше юзать   
уже в процессе оптимизации, для уменьшения нагрузки на GC(garbage collector),  
с другой - когда мы оборачиваем структуру в интерфейс, ее поведение может оказаться неожиданным для программиста.  
Лучше всего, структуры использовать для передачи данных(например при конфигурации обьектов)  
по значению или для обьектов, которые постоянно создаются/удаляются.  
 
Можно было бы конечно все краиво обернуть в тот же LINQ, но мне кажется, что в данном случае, это будет излишним -   
не все программисты им пользуются и он достаточно медленный. Кое-кто даже предвзято к нему относится.  
Его имеет смысл использовать как минимум в одном случае - если он утвержден корпоративным стандартом или идет работа   
на стыке множества языков программирования или хранилищ данных.  

Крайне спорным является отсылка событий без идентификаторов. Либо должны быть идентификаторы для каждого события,   
либо для сообщения с пакетом событий(но в таком случае ,перед отправкой пакета ,его данные должны сохраняться).  
Лучше использовать идентификаторы для сообщений.Это незначительно увеличит траффик, однако будет самым детерменированным подходом.  
Это все нужно для случая, когда сообщение на сервер отослалось, сервер его принял,   
а ответ от сервера мы не получили из-за разрыва связи или выключения устройства.  
Можно конечно слать на сервер подтверждение о приеме отсылки,   
а в ответ тот будет слать команду "очистки" нужного интервала.И это все с подтверждениями.  
Но лучше просто использовать идентификаторы.  
 
У нас нет реального удаленного сервера и нет локальной БД, поэтому хранилище и сообщения реализованы в тестовом виде.  
Для примера сендера, работаеющего по http сделал SimpleHttpSender.  
Для хранилища и сопутствующих классов, я бы использовал какой-нибудь удобный бинарный сериализатор.  
Из тех, что мне понравились, такой есть например у LightNetLib ну или в конце концов ,можно использовать встроенный.  
В случае локальной БД, сериализовывал бы "ручками" или через какую-нить ORM. Можно даже LINQ здесь использовать.  


