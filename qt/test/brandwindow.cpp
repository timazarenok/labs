#include "brandwindow.h"
#include "ui_brandwindow.h"

BrandWindow::BrandWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::BrandWindow)
{
    ui->setupUi(this);
}

BrandWindow::~BrandWindow()
{
    delete ui;
}
