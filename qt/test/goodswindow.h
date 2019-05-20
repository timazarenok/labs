#ifndef GOODSWINDOW_H
#define GOODSWINDOW_H

#include <QMainWindow>

namespace Ui {
class GoodsWindow;
}

class GoodsWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit GoodsWindow(QWidget *parent = nullptr);
    ~GoodsWindow();

private:
    Ui::GoodsWindow *ui;
};

#endif // GOODSWINDOW_H
