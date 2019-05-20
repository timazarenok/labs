#ifndef DATABASE_H
#define DATABASE_H

#include <QObject>
#include <QWidget>

class database : public QObject
{
    Q_OBJECT
public:
    explicit database(QObject *parent = nullptr);

signals:

public slots:
};

#endif // DATABASE_H