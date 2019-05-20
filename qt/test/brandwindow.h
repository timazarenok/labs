#ifndef BRANDWINDOW_H
#define BRANDWINDOW_H

#include <QMainWindow>

namespace Ui {
class BrandWindow;
}

class BrandWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit BrandWindow(QWidget *parent = nullptr);
    ~BrandWindow();

private:
    Ui::BrandWindow *ui;
};

#endif // BRANDWINDOW_H
