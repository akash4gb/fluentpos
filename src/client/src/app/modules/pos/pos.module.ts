import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PosRoutingModule } from './pos-routing.module';
import { MaterialModule } from 'src/app/core/material/material.module';
import { PosComponent } from './pos.component';
import { CustomerComponent } from './components/customer/customer.component';
import { CatalogComponent } from './components/catalog/catalog.component';
import { CustomerSelectionComponent } from './components/customer-selection/customer-selection.component';
import { CustomerInfoComponent } from './components/customer-info/customer-info.component';
import { ProductInfoComponent } from './components/product-info/product-info.component';

import { SharedModule } from 'src/app/core/shared/shared.module';
import { CartComponent } from './components/cart/cart.component';

@NgModule({
  declarations: [
    PosComponent,
    CustomerComponent,
    CatalogComponent,
    CustomerSelectionComponent,
    CustomerInfoComponent,
    ProductInfoComponent,
    CartComponent
  ],
  imports: [
    CommonModule,
    PosRoutingModule,
    MaterialModule,
    SharedModule
  ]
})
export class PosModule { }
