# GamePrototype

### Architecture

#### Model 类

###### Model 类维护一个4x4的棋盘，棋盘上的每一个分区为一个Partition对象

##### 事件

check_accepted

​	调用View里的方法显示输入正确

check_failed

​	调用View里的方法显示输入错误

##### 方法

​	check	判断队列里面的字母是否能够组成一个单词并触发事件

​	shuffle	重新产生字母方格

​			完成产生方格操作后调用View里的update_board方法

#### View 类

###### 是Form的一个子类

##### 事件

鼠标离开

​	调用model的check方法



#### Partition 类

###### 描述一个方框

##### 事件

鼠标经过

​	将这个对象对应的字母添加到model的队列里去

