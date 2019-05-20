#ifndef COUNTRYWINDOW_H
#define COUNTRYWINDOW_H

#include <QMainWindow>

namespace Ui {
class CountryWindow;
}

class CountryWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit CountryWindow(QWidget *parent = nullptr);
    ~CountryWindow();

private:
    Ui::CountryWindow *ui;
};

#endif // COUNTRYWINDOW_H
