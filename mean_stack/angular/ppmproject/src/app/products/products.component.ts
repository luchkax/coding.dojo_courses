import { Component, OnInit } from '@angular/core';
import { DataService } from './../data.service';
import { Product } from '../Product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Array<Product> = [];

  constructor(private _dataService: DataService,) { }

  ngOnInit() {
    this._dataService.productsObservable.subscribe( (products) => {
      this.products = products;
    });
  }

  deleteProduct(product) {
    const idx = this.products.indexOf(product);
    this.products.splice(idx, 1);
    this._dataService.updateProducts(this.products)
  }
}
