#include "countrywindow.h"
#include "ui_countrywindow.h"

CountryWindow::CountryWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::CountryWindow)
{
    ui->setupUi(this);
}

CountryWindow::~CountryWindow()
{
    delete ui;
}
