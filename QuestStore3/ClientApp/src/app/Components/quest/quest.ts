enum Category {
  a, b, c
}

export interface Quest {

user: string,
id: number,
name: string,
description: string,
price: number,
category: Category;
checkBoxAnswer: boolean
fileString: string
}
