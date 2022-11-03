import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { NavComponent } from './components/shared/nav/nav.component';
import { LivrariaAppComponent } from './components/livraria-app/livraria-app.component';
import { FiltersComponent } from './components/livraria-app/filters/filters.component';
import { ProductsListComponent } from './components/livraria-app/products-list/products-list.component';
import { ProductItemComponent } from './components/livraria-app/products-list/product-item/product-item.component';
import { BooksService } from './components/livraria-app/products-list/product-list.component.service';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    LivrariaAppComponent,
    FiltersComponent,
    ProductsListComponent,
    ProductItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [BooksService],
  bootstrap: [AppComponent]
})
export class AppModule { }
