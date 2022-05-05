import sys
from PyQt5.QtWidgets import QApplication, QWidget, QPushButton, QLineEdit, QMessageBox, QLabel
from PyQt5.QtGui import QIcon
from PyQt5.QtCore import pyqtSlot

class Example(QWidget):

    def __init__(self):
        super().__init__()

        self.initUI()


    def initUI(self):

        t1 = QLabel("Общая сумма:", self)
        t1.move(10,10)

        t2 = QLabel("Кол-во месяцев:", self)
        t2.move(10, 100)

        t3 = QLabel("Оплата:", self)
        t3.move(300, 100)

        self.l1 = QLineEdit(self)
        self.l1.move(110, 10)#менять

        self.l2 = QLineEdit(self)
        self.l2.move(110, 100)#менять

        self.l3 = QLineEdit(self)
        self.l3.move(350,100)

        b = QPushButton('Получить ответ', self)
        b.move(350,10)#менять
        b.clicked.connect(self.click)

        self.setGeometry(200, 200, 500, 200)
        self.setWindowTitle('QLineEdit')
        self.show()

    def click(self):
        try:
            f = open('file.txt', 'a')
            a = self.l1.text()
            b = self.l2.text()
            c = str((float(a) * 1.18) / float(b))
            self.l3.setText(c)
            f.writelines("Суммма кредита:{}\tМесяцев на возврат:{}\tКол-во денег к оплате в месяц:{}\n".format(a, b, c))
            f.close()

        except:
            msg = QMessageBox()
            msg.setWindowTitle("Error")
            msg.setText("Error")
            msg.setIcon(QMessageBox.Warning)

if __name__ == '__main__':

    app = QApplication(sys.argv)
    ex = Example()
    sys.exit(app.exec_())