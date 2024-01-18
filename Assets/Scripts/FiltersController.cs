using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterController : MonoBehaviour
{
    public Button applyFiltersButton;
    public List<Toggle> genreCheckboxes;

    private void Start()
    {
        applyFiltersButton.onClick.AddListener(ApplyFilters);
    }

    private void ApplyFilters()
    {
        // Handle the logic when "Apply Filters" button is clicked
        List<string> selectedGenres = new List<string>();

        foreach (Toggle checkbox in genreCheckboxes)
        {
            if (checkbox.isOn)
            {
                // The checkbox is selected
                selectedGenres.Add(checkbox.GetComponentInChildren<Text>().text);
            }
        }

        // Now 'selectedGenres' contains the genres that are selected

        // You can use these selected genres to filter your scatterplot data (pointList)

        // For simplicity, let's log the selected genres
        Debug.Log("Selected Genres: " + string.Join(", ", selectedGenres));

        // Here, you can filter and update your scatterplot based on selected genres
        // For instance, you may have a function like UpdateScatterplot(selectedGenres);
        // Call that function with the selected genres as a parameter.
    }
}
