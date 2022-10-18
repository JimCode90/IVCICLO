package com.example.ep2restaurantes.adapters;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.ep2restaurantes.R;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;
import java.util.HashMap;

public class CoffeAdapter extends RecyclerView.Adapter<CoffeAdapter.ViewHolder> {

    ArrayList<HashMap<String,String>> arrayList;
    public static OnItemClickListener onItemClickListener;

    public CoffeAdapter(ArrayList<HashMap<String,String>> arrayList) {
        this.arrayList = arrayList;
    }

    @NonNull
    @Override
    public CoffeAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_coffe, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull CoffeAdapter.ViewHolder holder, int position) {
        HashMap<String,String> map = arrayList.get(position);
        holder.tvCoffeNombre.setText(map.get("nombre"));
        Picasso.get().load(map.get("imagenchica")).into(holder.ivCoffeIcono);
    }

    @Override
    public int getItemCount() {
        return arrayList.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener{
        TextView tvCoffeNombre;
        ImageView ivCoffeIcono;

        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            tvCoffeNombre = itemView.findViewById(R.id.tvCoffeNombre);
            ivCoffeIcono = itemView.findViewById(R.id.ivCoffeIcono);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view) {
            Log.d("POSICION", String.valueOf(getLayoutPosition()));
            onItemClickListener.onItemClick(getLayoutPosition());
        }
    }

    public interface OnItemClickListener{
        void onItemClick(int position);
    }

    public void setOnItemClickListener(OnItemClickListener onItemClickListener){
        CoffeAdapter.onItemClickListener = onItemClickListener;
    }

}
