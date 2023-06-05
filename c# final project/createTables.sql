CREATE TABLE contact_page_table (
    name VARCHAR(200),
    email VARCHAR(200) PRIMARY KEY,
    user_message VARCHAR(MAX)
);

CREATE TABLE create_account (
    name VARCHAR(200),
    number VARCHAR(200),
    email VARCHAR(200) PRIMARY KEY
);

CREATE TABLE purchase_table (
    purchase_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name VARCHAR(200),
    how_many_to_buy INT,
    email VARCHAR(200),
    money_spent INT,
    FOREIGN KEY (email) REFERENCES create_account(email)
);

CREATE TABLE return_table (
    return_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name VARCHAR(200),
    how_many_to_return INT,
    email VARCHAR(200),
    FOREIGN KEY (email) REFERENCES create_account(email)
);

CREATE TABLE inventory (
    item_name VARCHAR(200) PRIMARY KEY,
    how_many INT
);