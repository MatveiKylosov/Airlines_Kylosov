CREATE TABLE `tickets` (
  `id` int(11) NOT NULL,
  `from` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `to` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `timeStart` datetime DEFAULT NULL,
  `timeEnd` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci

INSERT INTO `tickets` (`id`, `from`, `to`, `price`, `timeStart`, `timeEnd`) VALUES
(1, 'Москва', 'Санкт-Петербург', 3000, '2023-12-01 14:00:00', '2023-12-01 16:00:00'),
(2, 'Санкт-Петербург', 'Москва', 3000, '2023-12-02 10:00:00', '2023-12-02 12:00:00'),
(3, 'Москва', 'Казань', 2500, '2023-12-03 16:00:00', '2023-12-03 19:00:00'),
(4, 'Казань', 'Москва', 2500, '2023-12-04 09:00:00', '2023-12-04 12:00:00'),
(5, 'Москва', 'Новосибирск', 4500, '2023-12-05 13:00:00', '2023-12-05 19:00:00'),
(6, 'Новосибирск', 'Москва', 4500, '2023-12-06 08:00:00', '2023-12-06 14:00:00'),
(7, 'Москва', 'Екатеринбург', 3500, '2023-12-07 19:00:00', '2023-12-07 23:00:00'),
(8, 'Екатеринбург', 'Москва', 3500, '2023-12-08 15:00:00', '2023-12-08 19:00:00'),
(9, 'Москва', 'Сочи', 4000, '2023-12-09 10:00:00', '2023-12-09 14:00:00'),
(10, 'Сочи', 'Москва', 4000, '2023-12-10 12:00:00', '2023-12-10 16:00:00'),
(11, 'Москва', 'Краснодар', 3500, '2023-12-11 14:00:00', '2023-12-11 18:00:00'),
(12, 'Краснодар', 'Москва', 3500, '2023-12-12 10:00:00', '2023-12-12 14:00:00'),
(13, 'Москва', 'Владивосток', 7000, '2023-12-13 16:00:00', '2023-12-14 08:00:00'),
(14, 'Владивосток', 'Москва', 7000, '2023-12-14 09:00:00', '2023-12-15 01:00:00'),
(15, 'Москва', 'Калининград', 4000, '2023-12-15 13:00:00', '2023-12-15 17:00:00'),
(16, 'Калининград', 'Москва', 4000, '2023-12-16 08:00:00', '2023-12-16 12:00:00'),
(17, 'Москва', 'Ростов-на-Дону', 3500, '2023-12-17 19:00:00', '2023-12-17 23:00:00'),
(18, 'Ростов-на-Дону', 'Москва', 3500, '2023-12-18 15:00:00', '2023-12-18 19:00:00'),
(19, 'Москва', 'Уфа', 3000, '2023-12-19 10:00:00', '2023-12-19 14:00:00'),
(20, 'Уфа', 'Москва', 3000, '2023-12-20 12:00:00', '2023-12-20 16:00:00');
