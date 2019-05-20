#ifndef SIZEWINDOW_H
#define SIZEWINDOW_H

#include <QMainWindow>

namespace Ui {
class SizeWindow;
}

class SizeWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit SizeWindow(QWidget *parent = nullptr);
    ~SizeWindow();

private:
    Ui::SizeWindow *ui;
};

#endif // SIZEWINDOW_H
