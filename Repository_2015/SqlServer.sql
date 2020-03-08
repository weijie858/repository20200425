
--------------------------4数据完整性(下)----------------------------------------------------------------------

--  最少性:尽量选择单个键作为主键
--稳定性:尽量选择数值更新少的列作为主键


















--一次插入多行数据，可以使用INSERT…SELECT…、
--SELECT…INTO…或者UNION关键字来实现
--INSERT INTO <表名>(列名)
--SELECT <列名>
--FROM <源表名>

--INSERT INTO TongXunLu ('姓名','地址','电子邮件')
--SELECT SName,SAddress,SEmail
--FROM Students


--6更新删除数据

--UPDATE <表名> SET <列名 = 更新值> [WHERE <更新条件>]

--UPDATE Students 
--SET SAddress ='北京女子职业技术学校家政班' 
--WHERE SAddress = '北京女子职业技术学校刺绣班'

--UPDATE Scores
--SET Scores = Scores + 5
--WHERE Scores <= 95

--DELETE FROM <表名> [WHERE <删除条件>]
-- 使用DELETE删除数据时，不能删除被外键值所引用的数
--据行
--TRUNCATE TABLE <表名> 


