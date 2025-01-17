/* 
    Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов.
    Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds '

    Выведите только чётные числа от 1 до 10.
    Пример: 2,4,6,8,10

*/

DELIMITER //
CREATE PROCEDURE seconds_to_DT(seconds INT)
BEGIN
    DECLARE days INT default 0;
    DECLARE hours INT default 0;
    DECLARE minutes INT default 0;

    SET days = seconds / 86400;
    SET seconds = seconds % 86400;
  
    SET hours = seconds / 3600;
    SET seconds = seconds % 3600;

    SET minutes = seconds / 60;
    SET seconds = seconds % 60;

SELECT CONCAT
(
  days, ' days ',
  hours, ' hours ',
  minutes, ' minutes ',
  seconds, ' seconds'
) AS date_time;
END //
DELIMITER ;

CALL seconds_to_DT(123456);