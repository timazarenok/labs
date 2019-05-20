#include "sizewindow.h"
#include "ui_sizewindow.h"

SizeWindow::SizeWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::SizeWindow)
{
    ui->setupUi(this);
}

SizeWindow::~SizeWindow()
{
    delete ui;
}
